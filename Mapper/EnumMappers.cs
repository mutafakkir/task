namespace tasks.Mapper
{
    public static class EnumMappers
    {
        // Model to Entity
        public static Entity.ETaskPriority ToEntityETaskPriority(this Model.ETaskPriority? priority)
        {
            return priority switch
            {
                Model.ETaskPriority.High => Entity.ETaskPriority.High,
                Model.ETaskPriority.Mid => Entity.ETaskPriority.Mid,
                Model.ETaskPriority.Low => Entity.ETaskPriority.Low,
                _ => Entity.ETaskPriority.None,
            };
        }

        public static Entity.ETaskStatus ToEntityETaskStatus(this Model.ETaskStatus? status)
        {
            return status switch
            {
                Model.ETaskStatus.Completed => Entity.ETaskStatus.Completed,
                Model.ETaskStatus.InProgress => Entity.ETaskStatus.InProgress,
                Model.ETaskStatus.Postponed => Entity.ETaskStatus.Postponed,
                _ => Entity.ETaskStatus.None,
            };
        }

        public static Entity.ETaskRepeat ToEntityETaskRepeat(this Model.ETaskRepeat? repeat)
        {
            return repeat switch
            {
                Model.ETaskRepeat.Daily => Entity.ETaskRepeat.Daily,
                Model.ETaskRepeat.Hourly => Entity.ETaskRepeat.Hourly,
                Model.ETaskRepeat.Monthly => Entity.ETaskRepeat.Monthly,
                Model.ETaskRepeat.Weekly => Entity.ETaskRepeat.Weekly,
                Model.ETaskRepeat.Yearly => Entity.ETaskRepeat.Yearly,
                _ => Entity.ETaskRepeat.Never
            };
        }


        // Entity to Model 
        public static Model.ETaskRepeat ToModelETaskRepeat(this Entity.ETaskRepeat repeat)
        {
            return repeat switch
            {
                Entity.ETaskRepeat.Hourly => Model.ETaskRepeat.Hourly,
                Entity.ETaskRepeat.Daily => Model.ETaskRepeat.Daily,
                Entity.ETaskRepeat.Weekly => Model.ETaskRepeat.Weekly,
                Entity.ETaskRepeat.Monthly => Model.ETaskRepeat.Monthly,
                Entity.ETaskRepeat.Yearly => Model.ETaskRepeat.Yearly,
                _ => Model.ETaskRepeat.Never,
            };
        }

        public static Model.ETaskStatus ToModelETaskStatus(this Entity.ETaskStatus status)
        {
            return status switch
            {
                Entity.ETaskStatus.InProgress => Model.ETaskStatus.InProgress,
                Entity.ETaskStatus.Postponed => Model.ETaskStatus.Postponed,
                Entity.ETaskStatus.Completed => Model.ETaskStatus.Completed,
                _ => Model.ETaskStatus.None,
            };
        }

        public static Model.ETaskPriority ToModelETaskPriority(this Entity.ETaskPriority priority)
        {
            return priority switch
            {
                Entity.ETaskPriority.Low => Model.ETaskPriority.Low,
                Entity.ETaskPriority.Mid => Model.ETaskPriority.Mid,
                Entity.ETaskPriority.High => Model.ETaskPriority.High,
                _ => Model.ETaskPriority.None,
            };
        }
    }
}