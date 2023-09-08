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
    [Table("test_order_line_t")]
    public class TestOrderLineTDto
    {
        #region Fields
        private int? id;

        private int? Test_order_linesId;

        private List<DescDto> DescriptionsField;

        private decimal? MaxValueField;

        private decimal? MinValueField;

        private string? RefGuidField;

        private string? StringValueField;

        private DateTime? TestDateField;

        private string? TestOrderLineGuidField;

        private string? TestResultGuidField;

        private string? TestTypeGuidField;

        private string? TestTypeKindGuidField;

        private int? UnitMeasField;
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

        [Column("max_value")]
        public decimal? MaxValue
        {
            get
            {
                return MaxValueField;
            }
            set
            {
                MaxValueField = value;
            }
        }

        [Column("min_value")]
        public decimal? MinValue
        {
            get
            {
                return MinValueField;
            }
            set
            {
                MinValueField = value;
            }
        }

        [Column("ref_guid")]
        public string? RefGuid
        {
            get
            {
                return RefGuidField;
            }
            set
            {
                RefGuidField = value;
            }
        }

        [Column("string_value")]
        public string? StringValue
        {
            get
            {
                return StringValueField;
            }
            set
            {
                StringValueField = value;
            }
        }

        [Column("test_date")]
        public DateTime? TestDate
        {
            get
            {
                return TestDateField;
            }
            set
            {
                TestDateField = value;
            }
        }

        [Column("tol_guid")]
        public string? TestOrderLineGuid
        {
            get
            {
                return TestOrderLineGuidField;
            }
            set
            {
                TestOrderLineGuidField = value;
            }
        }

        [Column("test_res_guid")]
        public string? TestResultGuid
        {
            get
            {
                return TestResultGuidField;
            }
            set
            {
                TestResultGuidField = value;
            }
        }

        [Column("test_type_guid")]
        public string? TestTypeGuid
        {
            get
            {
                return TestTypeGuidField;
            }
            set
            {
                TestTypeGuidField = value;
            }
        }

        [Column("test_type_kind_guid")]
        public string? TestTypeKindGuid
        {
            get
            {
                return TestTypeKindGuidField;
            }
            set
            {
                TestTypeKindGuidField = value;
            }
        }

        [Column("unit_meas")]
        public int? UnitMeas
        {
            get
            {
                return UnitMeasField;
            }
            set
            {
                UnitMeasField = value;
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
        #endregion
    }
}
