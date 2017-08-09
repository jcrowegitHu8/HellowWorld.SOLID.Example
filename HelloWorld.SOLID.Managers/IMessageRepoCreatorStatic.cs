using HelloWorld.SOLID.Repositories;

namespace HelloWorld.SOLID.Managers
{
	public interface IMessageRepoCreatorStatic
	{
		IMessageRepository Create();
	}
}