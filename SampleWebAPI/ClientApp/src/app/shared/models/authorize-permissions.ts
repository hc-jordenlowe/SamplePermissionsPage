import { AuthorizationPermissions } from "./authorization-permissions.enum";

export function authorizePermissions(permissions: AuthorizationPermissions[]): MethodDecorator {
  const permissionsNeeded = permissions;
  return function(target: any, propertyKey: string, descriptor: PropertyDescriptor) {
      if (permissionsNeeded[0] !== AuthorizationPermissions.canDoDerp) {
        descriptor.value = function() { alert('You do not have permissions!'); };
      }

      return descriptor;
  };
}
