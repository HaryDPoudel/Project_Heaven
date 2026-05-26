namespace Project_Heaven.Pages
{
    public partial class Home
    {
        public List<ProjectChapter> Roadmap { get; set; } = new();
        public ProjectChapter? SelectedChapter { get; set; }

        protected override void OnInitialized()
        {
            Roadmap = new List<ProjectChapter>
        {
            new(3, "Debugging and Deploying", "Debugging in Visual Studio, ILogger, error boundaries, AOT compilation, Azure deployment.", "Guess the Number Game"),
            new(4, "Modal Dialogs", "Templated components, RenderFragment, EventCallback, CSS isolation.", "Reusable Modal Dialog Component"),
            new(5, "Local Storage", "JS Interop, IJSRuntime, Web Storage API.", "Local Storage Service"),
            new(6, "AI-Powered Smart Combo Box", "ML fundamentals, ONNX Runtime Web, semantic matching.", "AI Semantic-Search Combo Box"),
            new(7, "Weather App (PWA)", "PWA architecture, service workers, Geolocation API.", "5-Day Weather Forecast PWA"),
            new(8, "Shopping Cart", "App State pattern, Dependency Injection, service lifetimes.", "Preserved Shopping Cart"),
            new(9, "Kanban Board", "Event handling, attribute splatting, DOM focus.", "Interactive Kanban Board"),
            new(10, "Excel Reader", "InputFile, image resizing, QuickGrid.", "Excel Data Explorer"),
            new(11, "Expense Tracker", "EditForm, Data Annotation validation, IndexedDB.", "Local-First Expense Tracker"),
            new(12, "Task Manager", "Web API, HttpClient, EF Core, SQL Server.", "Full-Stack CRUD Task Manager"),
            new(13, "Securing the App", "Auth vs. Authorization, JWT tokens, AuthorizeView.", "Secure Claims Dashboard"),
            new(14, "Skill-Driven AI Assistant", "Agent-based AI design, OpenAI .NET library.", "OpenAI-Powered Agent Assistant")
        };
        }

        public void ToggleChapter(ProjectChapter chapter) =>
            SelectedChapter = (SelectedChapter == chapter) ? null : chapter;

        public class ProjectChapter
        {
            public int Id { get; }
            public string Name { get; }
            public string Objectives { get; }
            public string FinalProject { get; }
            public ProjectChapter(int id, string name, string obj, string proj)
                => (Id, Name, Objectives, FinalProject) = (id, name, obj, proj);
        }
    }
}
