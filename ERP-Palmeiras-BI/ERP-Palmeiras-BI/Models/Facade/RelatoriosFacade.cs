using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.DataVisualization.Charting;
using System.Drawing;
using ERP_Palmeiras_BI.Core;
using System.Data;
using System.IO;
using ERP_Palmeiras_BI.RHFuncionarios;
using ERP_Palmeiras_BI.InfoOperacional;

namespace ERP_Palmeiras_BI.Models.Facade
{
    public partial class BusinessIntelligence
    {

        private const String CHART_AREA_NAME = "ChartArea1";
        private const String SERIE_NAME = "Serie1";
        public const String GRAPHICS_PATH = @"~/Graphics/";

        public Relatorio BuscarRelatorio(int id)
        {
            IEnumerable<Relatorio> result = model.TblRelatorios.Where(r => r.Id == id);
            if (result != null && result.Count<Relatorio>() > 0)
                return result.First<Relatorio>();
            else
                return null;
        }

        public void AlterarRelatorio(int id, TipoRelatorio tipo, DateTime dataInicio, DateTime dataFim, String titulo, Usuario user, String urlImagem, String fileName)
        {
            IEnumerable<Relatorio> result = model.TblRelatorios.Where(r => r.Id == id);
            if (result != null && result.Count<Relatorio>() > 0)
            {
                Relatorio r = result.First<Relatorio>();
                r.Titulo = titulo;
                r.Tipo = tipo;
                r.UsuarioId = user.Id;
                r.DataModificacao = DateTime.Now.Ticks;
                r.DataInicio = dataInicio.Ticks;
                r.DataFim = dataFim.Ticks;
                Chart c = GerarGrafico(tipo, titulo, dataInicio, dataFim);
                String filePath = Path.Combine(System.Web.HttpContext.Current.Server.MapPath(GRAPHICS_PATH), fileName);
                c.SaveImage(filePath, ChartImageFormat.Png);
                Stream file = new FileStream(filePath, FileMode.Open);
                r.UrlImagem = urlImagem;
                model.Entry(user).State = EntityState.Modified;
                model.SaveChanges();
            }
            else
                throw new ERPException("Relatório " + id + " não encontrado.");
        }

        public Relatorio CriarRelatorio(TipoRelatorio tipo, DateTime dataInicio, DateTime dataFim, String titulo, Usuario user, String urlImagem, String fileName)
        {
            Relatorio r = new Relatorio();
            r.Titulo = titulo;
            r.Tipo = tipo;
            r.UsuarioId = user.Id;
            r.DataModificacao = DateTime.Now.Ticks;
            r.DataInicio = dataInicio.Ticks;
            r.DataFim = dataFim.Ticks;
            Chart c = GerarGrafico(tipo, titulo, dataInicio, dataFim);
            String filePath = Path.Combine(System.Web.HttpContext.Current.Server.MapPath(GRAPHICS_PATH), fileName);
            c.SaveImage(filePath, ChartImageFormat.Png);
            Stream file = new FileStream(filePath, FileMode.Open);
            r.UrlImagem = urlImagem;
            model.TblRelatorios.Add(r);
            model.SaveChanges();
            return r;
        }

        public IEnumerable<Relatorio> BuscarRelatorios()
        {
            return model.TblRelatorios.Where<Relatorio>(r => true);
        }

        public Chart GerarGrafico(TipoRelatorio tipo, String title, DateTime dataInicio, DateTime dataFim)
        {
            switch (tipo)
            {
                case TipoRelatorio.CONSULTAS_REALIZADAS:
                    return this.GerarGraficoConsultas(title, dataInicio, dataFim);
                case TipoRelatorio.ESPECIALIDADES_REQUISITADAS:
                    return this.GerarGraficoEspecialidades(title, dataInicio, dataFim);
                default:
                    throw new ERPException("Tipo de relatório inválido!");
            }
        }

        public Chart GerarGraficoEspecialidades(String title, DateTime dataInicio, DateTime dataFim)
        {
            Chart c = this.gerarGraficoBasico(title, false);

            // Show labels every day
            c.ChartAreas[CHART_AREA_NAME].AxisX.LabelStyle.Interval = 1;
            c.ChartAreas[CHART_AREA_NAME].AxisX.MajorGrid.Interval = 1;
            c.ChartAreas[CHART_AREA_NAME].AxisX.MajorTickMark.Interval = 1;

            Consulta[] consultas = infoOpClient.GetInfoConsultas(dataInicio, dataFim);


            Dictionary<String, int> points = new Dictionary<String, int>();

            foreach (Consulta con in consultas)
            {
                if (con.Finalizada)
                {
                    MedicoDTO mDto = funcClient.BuscarMedicoPorId(con.IDMedico);
                    if (points.ContainsKey(mDto.Especialidade))
                    {
                        points[mDto.Especialidade]++;
                    }
                    else
                    {
                        points.Add(mDto.Especialidade, 1);
                    }
                }
            }

            c.Series[SERIE_NAME].Points.DataBindXY(points.Keys, "Especialidade", points, "Value");

            return c;
        }


        public Chart GerarGraficoConsultas(String title, DateTime dataInicio, DateTime dataFim)
        {
            Chart c = this.gerarGraficoBasico(title, false);

            // Show labels every day
            c.ChartAreas[CHART_AREA_NAME].AxisX.LabelStyle.Interval = 1;
            c.ChartAreas[CHART_AREA_NAME].AxisX.MajorGrid.Interval = 1;
            c.ChartAreas[CHART_AREA_NAME].AxisX.MajorTickMark.Interval = 1;

            Consulta[] consultas = infoOpClient.GetInfoConsultas(dataInicio, dataFim);


            Dictionary<String, int> points = new Dictionary<String, int>();

            foreach (Consulta con in consultas)
            {
                if (con.Finalizada)
                {
                    if (points.ContainsKey(con.Data.ToString("dd/MM/yyyy")))
                    {
                        points[con.Data.ToString("dd/MM/yyyy")]++;
                    }
                    else
                    {
                        points.Add(con.Data.ToString("dd/MM/yyyy"), 1);
                    }
                }
            }

            c.Series[SERIE_NAME].Points.DataBindXY(points.Keys, "Data", points, "Value");

            return c;
        }


        private Chart gerarGraficoBasico(String titleStr, bool is3D)
        {
            Chart chart = new Chart();
            chart.ImageType = ChartImageType.Png;
            chart.BackColor = Color.WhiteSmoke;
            chart.BorderColor = Color.FromArgb(26, 59, 105);
            chart.BorderlineDashStyle = ChartDashStyle.Solid;
            chart.Palette = ChartColorPalette.BrightPastel;
            chart.BackSecondaryColor = Color.FromArgb(0xCC, 0xCC, 0xCC);
            chart.BackGradientStyle = GradientStyle.TopBottom;
            chart.BorderWidth = 2;
            chart.Width = 800;
            chart.Height = 400;
            chart.BorderSkin.SkinStyle = BorderSkinStyle.Emboss;

            Title title = new Title();
            title.Alignment = ContentAlignment.TopCenter;
            title.Font = new Font("Arial", 18f, FontStyle.Underline);
            title.ForeColor = Color.DarkBlue;
            title.Text = titleStr;
            chart.Titles.Add(title);

            ChartArea chartArea = new ChartArea();
            ChartArea3DStyle area3DStyle = new ChartArea3DStyle();
            area3DStyle.Rotation = 20;
            area3DStyle.Perspective = 10;
            area3DStyle.Inclination = 28;
            area3DStyle.IsRightAngleAxes = false;
            area3DStyle.WallWidth = 0;
            area3DStyle.IsClustered = false;
            area3DStyle.Enable3D = is3D;
            chartArea.Area3DStyle = area3DStyle;

            Axis axisy = new Axis();
            axisy.LineColor = Color.FromArgb(64, 64, 64, 64);
            axisy.LabelStyle = new LabelStyle() { Font = new Font("Trebuchet MS", 8.25f, FontStyle.Bold) };
            axisy.MajorGrid.LineColor = Color.FromArgb(64, 64, 64, 64);

            Axis axisx = new Axis();
            axisx.LineColor = Color.FromArgb(64, 64, 64, 64);
            axisx.LabelStyle = new LabelStyle() { Font = new Font("Trebuchet MS", 8.25f, FontStyle.Bold) };
            axisx.MajorGrid.LineColor = Color.FromArgb(64, 64, 64, 64);

            chartArea.AxisY = axisy;
            chartArea.AxisX = axisx;

            chartArea.Name = CHART_AREA_NAME;

            chart.ChartAreas.Add(chartArea);

            chart.Series.Add(new Series(SERIE_NAME));
            chart.ImageStorageMode = ImageStorageMode.UseImageLocation;
            chart.RenderType = RenderType.ImageTag;
            return chart;
        }
    }
}