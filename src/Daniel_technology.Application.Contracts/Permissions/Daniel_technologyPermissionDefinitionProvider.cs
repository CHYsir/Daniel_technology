using Daniel_technology.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Daniel_technology.Permissions;

public class Daniel_technologyPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(Daniel_technologyPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(Daniel_technologyPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<Daniel_technologyResource>(name);
    }
}
