using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Threading.Tasks;
using System.Web.Http;

namespace PresupuestoService.Controllers
{
    public class PresupuestoController : ApiController
    {
        private Core.MainCore _ = new Core.MainCore();

        #region GET

        // GET: api/Presupuesto
        [HttpGet]
        [Route("api/Presupuesto")]
        public List<Core.DB.Models.PresupuestoDBModel> Get()
        {
            var data = _.ReadAll();

            return data;
        }

        // GET: api/Presupuesto/5
        [HttpGet]
        [Route("api/Presupuesto/{id}")]
        public Core.DB.Models.PresupuestoDBModel Get(string id)
        {
            var data = _.ReadId(id);

            return data;
        }

        #endregion

        #region POST

        // POST: api/Presupuesto
        [HttpPost]
        [Route("api/Presupuesto")]
        public async Task<HttpResponseMessage> Post(HttpRequestMessage request)
        {
            var jsonString = await request.Content.ReadAsStringAsync();

            Core.DB.Models.PresupuestoDBModel account = JsonConvert.DeserializeObject<Core.DB.Models.PresupuestoDBModel>(jsonString);
            _.CrearPresupuesto(account);

           // return "OK!";
            return new HttpResponseMessage(HttpStatusCode.Created);
        }

        #endregion

        #region PUT

        // PUT: api/Presupuesto/5
        [HttpPut]
        [Route("api/Presupuesto/{id}")]
        public string Put(string id, FormDataCollection value)
        {
            var name = value.FirstOrDefault().Key.ToString();
            var valor = value.FirstOrDefault().Value.ToString();

            Core.DB.Models.PresupuestoDBModel obj = new Core.DB.Models.PresupuestoDBModel();
            var existeMetodo = obj.GetType().GetProperty(name) == null ? false : true;
            if (existeMetodo == true)
            {
                _.Update(id, name, valor);
                return "OK!";
            }

            return "Error";
        }

        #endregion

        #region DELETE

        // DELETE: api/Presupuesto/5
        [HttpDelete]
        [Route("api/Presupuesto/{id}")]
        public void Delete(string id)
        {
            _.Delete(id);
        }

        #endregion

    }
}