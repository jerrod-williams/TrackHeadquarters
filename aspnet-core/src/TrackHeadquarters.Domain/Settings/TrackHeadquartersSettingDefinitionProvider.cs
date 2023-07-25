using Volo.Abp.Settings;

namespace TrackHeadquarters.Settings;

public class TrackHeadquartersSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(TrackHeadquartersSettings.MySetting1));
    }
}
