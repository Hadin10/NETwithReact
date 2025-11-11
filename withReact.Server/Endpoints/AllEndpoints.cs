namespace withReact.Server.Endpoints
{
    public static class AllEndpoints
    {
        internal static void MapAllEndpoints(this IEndpointRouteBuilder app)
        {
            app.MapDashboardEndpoints();
        }

    }
}
