using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PresupuestoService.Core
{
    public class MainCore
    {
        #region CREATE

        public void CrearRastreo(Core.DB.Models.PresupuestoDBModel data)
        {

            Core.DB.Query.PresupuestoQuery qCreate = new Core.DB.Query.PresupuestoQuery("mongodb://51.83.73.69:27017");
            qCreate.CrearRastreo(data);

        }

        #endregion

        #region READ

        public List<Core.DB.Models.PresupuestoDBModel> ReadAll()
        {
            Core.DB.Query.PresupuestoQuery qReadAll = new Core.DB.Query.PresupuestoQuery("mongodb://51.83.73.69:27017");

            return qReadAll.GetAllPresupuesto();
        }

        public Core.DB.Models.PresupuestoDBModel ReadId(string id)
        {

            Core.DB.Query.PresupuestoQuery qReadId = new Core.DB.Query.PresupuestoQuery("mongodb://51.83.73.69:27017");

            var data = qReadId.GetPresupuestoById(id);
            return data;
        }

        // ESTE ES EL CAMPO DE BUSQUEDA. BUSCA POR VALOR CLAVE Y AHORA MISMO NO ESTA IMPLEMENTADO EN EL QUERY


        //public List<Core.DB.Models.PresupuestoDBModel> ReadValue(string fieldName, string fieldValue)
        //{
        //    Core.DB.Query.PresupuestoQuery qReadId = new Core.DB.Query.PresupuestoQuery("mongodb://51.83.73.69:27017");

        //    var data = qReadId.GetPresupuestoByField(fieldName, fieldValue);
        //    return data;

        //}

        #endregion

        #region UPDATE

        public void Update(string id, string updateFieldName, string updateFieldValue)
        {

            Core.DB.Query.PresupuestoQuery qUpdate = new Core.DB.Query.PresupuestoQuery("mongodb://51.83.73.69:27017");
            qUpdate.UpdatePresupuesto(id, updateFieldName, updateFieldValue);

        }

        #endregion

        #region DELETE

        public void Delete(string id)
        {
            Core.DB.Query.PresupuestoQuery qDelete = new Core.DB.Query.PresupuestoQuery("mongodb://51.83.73.69:27017");
            qDelete.DeletePresupuestoById(id);
        }

        #endregion
    }
}