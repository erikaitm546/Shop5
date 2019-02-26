


namespace Shop5.UIForms.Infrastructure
{
    using Shop5.UIForms.ViewModels;
    public class InstanceLocator
    {
        public MainViewModel Main { get; set; }

        public InstanceLocator()
        {
            this.Main = new MainViewModel();
        }
    }

}
