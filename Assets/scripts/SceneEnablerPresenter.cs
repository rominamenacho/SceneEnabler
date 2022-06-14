namespace Assets.scripts
{
    class SceneEnablerPresenter
    {
        private SceneEnabler _sceneEnablerMono;

        public SceneEnablerPresenter(SceneEnabler sceneEnabler)
        {
            _sceneEnablerMono = sceneEnabler;
            _sceneEnablerMono.EnableMono2 += GoToScene2;
            _sceneEnablerMono.EnableMono3 += GoToScene3;
            _sceneEnablerMono.EnableMono1 += GoToScene1;
        }

        private void GoToScene2()
        {
            _sceneEnablerMono.ActiveScene2();
        }
        private void GoToScene3()
        {
            _sceneEnablerMono.ActiveScene3();
        }
        private void GoToScene1()
        {
            _sceneEnablerMono.ActiveScene1();
        }
    }
}
