namespace RRModels {
    public class Reviews {
        /// <summary>
        /// This describes the overall numeric rating of a restaurant
        /// </summary>
        /// <value></value>
        public int Rating { get; set; }
        
        /// <summary>
        /// Verbose description of the dining experience
        /// </summary>
        /// <value></value>
        public string Description { get; set; }

        public override string ToString()
        {
            return $"\tRating: {Rating} \n\tDescription: {Description}";
        }
    }
}