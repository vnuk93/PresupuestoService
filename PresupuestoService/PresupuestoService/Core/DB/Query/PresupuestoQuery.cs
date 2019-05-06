using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace PresupuestoService.Core.DB.Query
{
    public class PresupuestoQuery
    {
        private IMongoClient _client;
        private IMongoDatabase _database;
        private IMongoCollection<Core.DB.Models.PresupuestoDBModel> _presupuestoCollection;

        public PresupuestoQuery(string connectionString)
        {
            _client = new MongoClient(connectionString);
            _database = _client.GetDatabase("PresupuestoService");
            _presupuestoCollection = _database.GetCollection<Core.DB.Models.PresupuestoDBModel>("presupuestos");
        }

        #region CREATE

        public async Task CrearRastreo(Core.DB.Models.PresupuestoDBModel user) //CREATE
        {
            await _presupuestoCollection.InsertOneAsync(user);
        }

        #endregion

        #region READ

        public List<Core.DB.Models.PresupuestoDBModel> GetAllPresupuesto()
        {
            return _presupuestoCollection.Find(new BsonDocument()).ToList();
        }

        public Core.DB.Models.PresupuestoDBModel GetPresupuestoById(string id)
        {
            try
            {
                var filter = Builders<Core.DB.Models.PresupuestoDBModel>.Filter.Eq("_id", ObjectId.Parse(id));
                var data = _presupuestoCollection.Find(filter).FirstOrDefault();
                return data;
            }
            catch
            {
                return null;
            }
        }

        #endregion

        #region UPDATE

        public bool UpdatePresupuesto(string id, string udateFieldName, string updateFieldValue)
        {
            var filter = Builders<Core.DB.Models.PresupuestoDBModel>.Filter.Eq("_id", ObjectId.Parse(id));
            var update = Builders<Core.DB.Models.PresupuestoDBModel>.Update.Set(udateFieldName, updateFieldValue);

            var result = _presupuestoCollection.UpdateOne(filter, update);

            return result.ModifiedCount != 0;
        }

        #endregion

        #region DELETE

        public bool DeletePresupuestoById(string id)
        {
            var filter = Builders<Core.DB.Models.PresupuestoDBModel>.Filter.Eq("_id", ObjectId.Parse(id));
            var result = _presupuestoCollection.DeleteOne(filter);
            return result.DeletedCount != 0;
        }


        #endregion

    }
}