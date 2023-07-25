using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace TrackHeadquarters;

[Dependency(ReplaceServices = true)]
public class TrackHeadquartersBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "TrackHeadquarters";
}
