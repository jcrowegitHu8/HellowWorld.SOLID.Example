using HelloWorld.SOLID.Repositories;

namespace HelloWorld.SOLID.Managers
{
	public interface IMessageRepoCreatorDynamic
	{
		IMessageRepository Create();
	}
}