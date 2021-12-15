using ServiceClient.Infrastructure.Models.Entity.Interfaces.Audit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceClient.Infrastructure.Models.Entity
{
    public  class WeekSchdeuleEntity: IGenericEntity
    {
        #region interface implementation
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public bool IsDeleted { get; set; }
        #endregion

        public ICollection<DaySchdeuleEnity>? DailySchedules { get; set; }

    }

    public class DaySchdeuleEnity : IGenericEntity
    {
        #region interface implementation
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public bool IsDeleted { get; set; }
        #endregion
        
        public DayOfWeek DayOfWeek { get; set; }


        public int WeekScheduleId { get; set; }
        public WeekSchdeuleEntity WeekSchdeule { get; set; }



        public ICollection<TimeSpanSlot>? TimeSpans { get; set; }


    }

    public class TimeSpanSlot : IGenericEntity
    {
        #region interface implementation
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public bool IsDeleted { get; set; }
        #endregion

        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }



        public int DayScheduleId { get; set; }
        public DaySchdeuleEnity DaySchdeule { get; set; }

    }
}
