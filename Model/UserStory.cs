namespace UserStoryRazorPageApplikation.Model
{
    public class UserStory

    {
        private string v1;
        private string v2;

        public UserStory(string v1, string v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        public UserStory(int id, string titel, string description)
        {
            Id = id;
            Titel = titel;
            Description = description;
        }
        public int Id { get; set; }
        public string Titel { get; set;}
        public string Description { get; set; }

        public override string ToString()
        {
            return $"{{{nameof(Id)}={Id}, {nameof(Titel)}={Titel}, {nameof(Description)}={Description}}}";
        }
    }
}
