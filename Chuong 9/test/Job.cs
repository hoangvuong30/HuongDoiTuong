using Microsoft.VisualBasic.CompilerServices;

namespace test
{
    public class Job
    {
        /// <summary>
        /// description (for example, “wash windows”)
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// time in hours to complete
        /// </summary>
        public double Hours { get; set; }
        /// <summary>
        /// per-hour rate charged
        /// </summary>
        public double Rate { get; set; }
        /// <summary>
        /// hourly rate times hours
        /// </summary>
        public readonly double TotalFee;

        //public Job()
        //{

        //}

        public Job(string description, double hours, double rate)
        {
            Description = description;
            Hours = hours;
            Rate = rate;
            TotalFee = hours * rate;
        }

        public static Job operator +(Job a, Job b)
        {
            return new Job(a.Description + " and " + b.Description, a.Hours + b.Hours, (a.Rate + b.Rate) / 2);
        }

        public override string ToString()
        {
            return string.Format("Description: {0}, Hours: {1}, Rate: {2}, Fee:{3}", Description, Hours, Rate,TotalFee);
        }
    }

}
