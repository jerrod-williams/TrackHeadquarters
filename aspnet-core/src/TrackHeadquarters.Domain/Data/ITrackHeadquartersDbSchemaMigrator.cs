using System.Threading.Tasks;

namespace TrackHeadquarters.Data;

public interface ITrackHeadquartersDbSchemaMigrator
{
    Task MigrateAsync();
}
