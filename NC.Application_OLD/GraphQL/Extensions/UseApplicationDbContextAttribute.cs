using HotChocolate.Types;
using HotChocolate.Types.Descriptors;
using NexcodeControls.Data.Context;
using System.Reflection;


namespace NexcodeControls.Api.GraphQL.Extensions
{
    public class UseApplicationDbContextAttribute : ObjectFieldDescriptorAttribute
    {
        public override void OnConfigure(
            IDescriptorContext context,
            IObjectFieldDescriptor descriptor,
            MemberInfo member)
        {
            descriptor.UseDbContext<NexcodeControlsContext>();
        }
    }
}
