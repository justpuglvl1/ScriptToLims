using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConnectionToDB.Models.Dto_models
{
	[Table("doc_route_step_t")]
    public class DocumentRouteStepTDto
    {
        #region Fields
        private int? id;

        private string? DocumentRouteStepGuidField;

        private string? DocumentStatusField;

        private int? NoField;

        private int? OperationCodeField;

        private DateTime? OperationDateField;

        private string? UnitCodeField;

        private int? Test_order_linesId;
        #endregion

        #region Properties

        [Key]
        [Column("Id")]
        public int? Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        [Column("doc_r_st_guid")]
        public string? DocumentRouteStepGuid
        {
            get
            {
                return DocumentRouteStepGuidField;
            }
            set
            {
                DocumentRouteStepGuidField = value;
            }
        }

        [Column("doc_status")]
        public string? DocumentStatus
        {
            get
            {
                return DocumentStatusField;
            }
            set
            {
                DocumentStatusField = value;
            }
        }

        [Column("no")]
        public int? No
        {
            get
            {
                return NoField;
            }
            set
            {
                NoField = value;
            }
        }

        [Column("operation_code")]
        public int? OperationCode
        {
            get
            {
                return OperationCodeField;
            }
            set
            {
                OperationCodeField = value;
            }
        }

        [Column("operation_date")]
        public DateTime? OperationDate
        {
            get
            {
                return OperationDateField;
            }
            set
            {
                OperationDateField = value;
            }
        }

        [Column("unit_code")]
        public string? UnitCode
        {
            get
            {
                return UnitCodeField;
            }
            set
            {
                UnitCodeField = value;
            }
        }

        [Column("TestOrderLinesDtoId")]
        public int? TestOrderLinesDtoId
        {
            get
            {
                return Test_order_linesId;
            }
            set
            {
                Test_order_linesId = value;
            }
        }

        #endregion
    }
}
