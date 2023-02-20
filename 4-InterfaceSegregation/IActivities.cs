namespace InterfaceSegregation
{
    public interface IActivities: IWorkTeamActivities,IDevelopActivities,ITestActivities
    {
        void Design();
    }
}