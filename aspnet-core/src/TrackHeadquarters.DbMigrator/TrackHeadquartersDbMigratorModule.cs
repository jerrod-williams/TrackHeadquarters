using TrackHeadquarters.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace TrackHeadquarters.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(TrackHeadquartersEntityFrameworkCoreModule),
    typeof(TrackHeadquartersApplicationContractsModule)
    )]
public class TrackHeadquartersDbMigratorModule : AbpModule
{
}
