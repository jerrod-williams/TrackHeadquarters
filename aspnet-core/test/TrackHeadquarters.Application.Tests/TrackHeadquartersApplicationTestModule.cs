using Volo.Abp.Modularity;

namespace TrackHeadquarters;

[DependsOn(
    typeof(TrackHeadquartersApplicationModule),
    typeof(TrackHeadquartersDomainTestModule)
    )]
public class TrackHeadquartersApplicationTestModule : AbpModule
{

}
