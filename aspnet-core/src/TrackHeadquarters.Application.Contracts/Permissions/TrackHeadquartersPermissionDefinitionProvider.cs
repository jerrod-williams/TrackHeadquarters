using TrackHeadquarters.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace TrackHeadquarters.Permissions;

public class TrackHeadquartersPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(TrackHeadquartersPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(TrackHeadquartersPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<TrackHeadquartersResource>(name);
    }
}
