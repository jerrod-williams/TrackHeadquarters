using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace TrackHeadquarters.Data;

/* This is used if database provider does't define
 * ITrackHeadquartersDbSchemaMigrator implementation.
 */
public class NullTrackHeadquartersDbSchemaMigrator : ITrackHeadquartersDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
