using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.CompilerServices;

namespace ERP_Palmeiras_RH.Models.Facade
{
    public class CargosFacade
    {
        private static volatile CargosFacade instance;

        private CargosFacade() { }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public static CargosFacade GetInstance()
        {
            if (instance == null)
            {
                instance = new CargosFacade();
            }

            return instance;
        }

        public IEnumerable<Cargo> BuscarCargos()
        {
            ModelRH model = new ModelRH();
            return model.TblCargos.Where<Cargo>(c => true);
        }

        public Cargo BuscarCargo(int id)
        {
            ModelRH model = new ModelRH();
            return model.TblCargos.Where<Cargo>(c => c.Id == id).First<Cargo>();
        }
    }
}