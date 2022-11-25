using System.Runtime.ConstrainedExecution;
using UserStoryRazorPageApplikation.Model;

namespace UserStoryRazorPageApplikation.MockData
{
    public class MockUserStories
    {
        private static List<UserStory> userStories = new List<UserStory>()
{

    new UserStory("Create Story", "As P.O I want to create a new Story So ..."),
    new UserStory("Edit Story", "As P.O I want to edit a Story So ..."),
    new UserStory("Move Story", "As team member I want to move a Story So ..."),
    new UserStory("Delete Story", "As team member I want to delete a Story So ...")
    new UserStory("Delete", "test")
        };

        public List<UserStory> GetMockUserStories() 
        {
            return userStories;
        }
    }
}
