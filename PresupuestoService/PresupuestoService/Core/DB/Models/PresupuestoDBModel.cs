using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PresupuestoService.Core.DB.Models
{
    public class PDFGenerado {
        [BsonIgnoreIfNull]
        public DateTime fecha { get; set; }
        [BsonIgnoreIfNull]
        public ObjectId PDFGeneradoDocumentService { get; set; }
        [BsonIgnoreIfNull]
        public ObjectId PDFFirmadoDocumentService { get; set; }
    }

    public class PresupuestoDBModel
    {
        public ObjectId _id { get; set; }
        [BsonIgnoreIfNull]
        public List<ObjectId> contactoService { get; set; }
        [BsonIgnoreIfNull]
        public List<ObjectId> rastreoService { get; set; }
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
        public string telefono { get; set; }
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
        public bool presupuestoModificado { get; set; } = true;
        [BsonIgnoreIfNull]
        public List<PDFGenerado> pdfGenerado { get; set; }
        [BsonIgnoreIfNull]
        public bool clienteFirmado { get; set; } = false;
        [BsonIgnoreIfNull]
        public bool presupuestoDesechado { get; set; } = false;
        [BsonIgnoreIfNull]
        public bool motivoDesechado { get; set; } = false;
    }
}