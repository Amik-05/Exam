namespace Test2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Activities
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public int? EventID { get; set; }

        public DateTime? DateStart { get; set; }

        public int? Days { get; set; }

        public string Activity { get; set; }

        public TimeSpan? TimeStart { get; set; }

        public int? Moderator { get; set; }

        public int? JuryID { get; set; }

        public virtual Product Events { get; set; }

        public virtual Jury Jury { get; set; }

        public virtual Moderators Moderators { get; set; }
    }
}
