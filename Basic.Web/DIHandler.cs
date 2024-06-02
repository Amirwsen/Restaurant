// using Microsoft.EntityFrameworkCore;
// using Microsoft.EntityFrameworkCore.Diagnostics;
//
// namespace Basic.Web;
//
// public class DIHandler
// {
//     public static void HandleBuilder(WebApplicationBuilder builder)
//     {
//         builder.Services.AddDbContext<BasicDbContext>(options =>
//             options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"),
//                     optionsBuilder => optionsBuilder.MigrationsHistoryTable("Basic", "Migration")
//                         .UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery))
//                 .ConfigureWarnings(configurationBuilder =>
//                     configurationBuilder.Ignore(CoreEventId.NavigationBaseIncludeIgnored)));
//     }
// }