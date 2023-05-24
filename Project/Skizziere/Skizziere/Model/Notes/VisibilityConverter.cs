namespace Skizziere.Model.Notes
{
    public static class VisibilityConverter
    {
        public static string VisibilityToSting(VisibilityState state) 
        {
            return state switch
            {
                VisibilityState.Visible => "Visible",
                VisibilityState.Collapsed => "Collapsed",
                VisibilityState.Hidden => "Hidden",
                _ => throw new System.Exception("Invalid VisibilityState: " + state.ToString())
            };
        }

        public static VisibilityState VisibilityToVisibilityState(string state)
        {
            return state switch
            {
                "Visible" => VisibilityState.Visible,
                "Collapsed" => VisibilityState.Collapsed,
                "Hidden" => VisibilityState.Hidden,
                _ => throw new System.Exception("Invalid VisibilityState: " + state)
            };
        }
    }
}
