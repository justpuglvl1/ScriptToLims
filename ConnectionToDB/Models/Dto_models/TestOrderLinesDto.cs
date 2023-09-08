using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConnectionToDB.Models.Dto_models
{
    [Table("test_order_lines")]
    public class TestOrderLinesDto
    {
        #region Fields
        private int id;
        private List<DescDto> DescriptionsField;

        private DateTime? DocumentDateField;

        private List<DocumentRouteStepTDto> DocumentRouteStepsField;

        private string? DstUnitCodeField;

        private string? MessageEventTypeField;

        private string? NameField;

        private string? NoField;

        private string? TestOrderGuidField;

        private List<TestOrderLineTDto> TestOrderLinesField;

        private string? UnitCodeField;
        #endregion

        #region Properties

        [Key]
        [Column("Id")]
        public int Id
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

        public List<DescDto>? Descriptions
        {
            get
            {
                return DescriptionsField;
            }
            set
            {
                DescriptionsField = value;
            }
        }

        public List<DocumentRouteStepTDto>? DocumentRouteSteps
        {
            get
            {
                return DocumentRouteStepsField;
            }
            set
            {
                DocumentRouteStepsField = value;
            }
        }
        
        public List<TestOrderLineTDto>? TestOrderLineT
        {
            get
            {
                return TestOrderLinesField;
            }
            set
            {
                TestOrderLinesField = value;
            }
        }

        [Column("message_event_type")]
        public string? MessageEventType
        {
            get
            {
                return MessageEventTypeField;
            }
            set
            {
                MessageEventTypeField = value;
            }
        }

        [Column("document_date")]
        public DateTime? DocumentDate
        {
            get
            {
                return DocumentDateField;
            }
            set
            {
                DocumentDateField = value;
            }
        }

        [Column("dst_unit_code")]
        public string? DstUnitCode
        {
            get
            {
                return DstUnitCodeField;
            }
            set
            {
                DstUnitCodeField = value;
            }
        }

        [Column("name")]
        public string? Name
        {
            get
            {
                return NameField;
            }
            set
            {
                NameField = value;
            }
        }

        [Column("no")]
        public string? No
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

        [Column("test_order_guid")]
        public string? TestOrderGuid
        {
            get
            {
                return TestOrderGuidField;
            }
            set
            {
                TestOrderGuidField = value;
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

        [Column("status")]
        public string? Status { get; set; }
        #endregion
    }
}
