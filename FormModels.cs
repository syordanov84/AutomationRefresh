namespace AutomatedTestsRefresh
{
    public static class FormModels
    {
        public static Models Create()
        {
            return new Models
            {
                FirstName = "Stoyan",
                LastName = "Yordanov",
                UserEmail = "email@gmail.com",
                UserNumber = "0888555666",
                Subjects = "test"
            };
        }
    }
}
