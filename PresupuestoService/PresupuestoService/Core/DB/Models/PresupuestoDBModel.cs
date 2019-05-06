using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PresupuestoService.Core.DB.Models
{
    public class PresupuestoDBModel
    {
        public ObjectId _id { get; set; }
        public List<ObjectId> contactoID { get; set; }
        [BsonIgnoreIfNull]
        public List<ObjectId> rastreosID { get; set; }
        [BsonIgnoreIfNull]
        public DateTime fecha { get; set; }
        [BsonIgnoreIfNull]
        public string particularEmpresa { get; set; }
        [BsonIgnoreIfNull]
        public string nombre { get; set; }
        [BsonIgnoreIfNull]
        public string apellidos { get; set; }
        [BsonIgnoreIfNull]
        public string dni { get; set; }
        [BsonIgnoreIfNull]
        public string municipio { get; set; }
        [BsonIgnoreIfNull]
        public string direccion { get; set; }
        [BsonIgnoreIfNull]
        public string nombreEmpresa { get; set; }
        [BsonIgnoreIfNull]
        public string cif { get; set; }
        [BsonIgnoreIfNull]
        public string telefono1 { get; set; }
        [BsonIgnoreIfNull]
        public string email { get; set; }
        [BsonIgnoreIfNull]
        public List<string> buscadoresContratados { get; set; }
        [BsonIgnoreIfNull]
        public List<string> keyWords { get; set; }
        [BsonIgnoreIfNull]
        public string totalPresupuesto { get; set; }
        [BsonIgnoreIfNull]
        public string moneda { get; set; }
        [BsonIgnoreIfNull]
        public int numeroLinks { get; set; }
        [BsonIgnoreIfNull]
        public string plazosPago { get; set; }
        [BsonIgnoreIfNull]
        public bool clienteFirmado { get; set; }
    }
}