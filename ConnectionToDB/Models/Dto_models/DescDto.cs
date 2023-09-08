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
	[Table("desc")]
    public class DescDto
    {
        #region Fields
        private int? id; //

        private DateTime? BeginDateField;

        private string? DescGuidField;

        private string? DescTypeGuidField;

        private DateTime? EndDateField;

        private decimal? MaxValueField;

        private decimal? MinValueField;

        private string? RefGuidField;

        private string? StringValueField;

        private int? UnitMeasField;

        private int? Test_order_line_tId; //
        private int? Test_order_linesId; //
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

        [Column("begin_date")]
        public DateTime? BeginDate
        {
            get
            {
                return BeginDateField;
            }
            set
            {
                BeginDateField = value;
            }
        }

        [Column("desc_guid")]
        public string? DescGuid
        {
            get
            {
                return DescGuidField;
            }
            set
            {
                DescGuidField = value;
            }
        }

        [Column("desc_type_guid")]
        public string? DescTypeGuid
        {
            get
            {
                return DescTypeGuidField;
            }
            set
            {
                DescTypeGuidField = value;
            }
        }

        [Column("end_date")]
        public DateTime? EndDate
        {
            get
            {
                return EndDateField;
            }
            set
            {
                EndDateField = value;
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

        [Column("TestOrderLineTDtoId")]
        public int? TestOrderLineTDtoId
        {
            get
            {
                return Test_order_line_tId;
            }
            set
            {
                Test_order_line_tId = value;
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
