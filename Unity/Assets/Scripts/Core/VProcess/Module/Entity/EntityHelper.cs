namespace ET
{
    public static class EntityHelper
    {
        public static int DomainZone(this Entity entity)
        {
            return (entity.IScene as Scene)?.Zone ?? 0;
        }

        public static Scene Scene(this Entity entity)
        {
            return entity.IScene as Scene;
        }
        
        public static Scene Root(this Entity entity)
        {
            return entity.IScene.Root as Scene;
        }
        
        public static VProcess VProcess(this Entity entity)
        {
            return entity.IScene.VProcess;
        }
    }
}