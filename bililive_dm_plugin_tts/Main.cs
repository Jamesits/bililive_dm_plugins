using metadata;
using System.Diagnostics;
using System.Reflection;

namespace bililive_dm_plugin_tts
{
    public class Main : BilibiliDM_PluginFramework.DMPlugin
    {
        private readonly SettingsUI settingsUI = new SettingsUI();
        private readonly ITTSBridge bridge = new TTSBridgeWindows();

        public Main()
        {
            // metadata
            PluginName = "TTS";
            PluginDesc = "Reads messages aload in a robotic sound";
            PluginVer = FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).ProductVersion;
            PluginAuth = Metadata.PluginAuthor;
            PluginCont = Metadata.PluginContact;

            // callbacks
            ReceivedDanmaku += CallbackReceivedDanmaku;
        }

        // Triggered on right-click -> Manage
        // blocking the thread here is not allowed
        public override void Admin()
        {
            base.Admin();
            settingsUI.Show();
        }

        // blocking the thread here is not allowed
        public override void Stop()
        {
            base.Stop();
            Log("Plugin Stoped!");
        }

        // blocking the thread here is not allowed
        public override void Start()
        {
            base.Start();
            Log("Plugin Started!");
        }

        private void CallbackReceivedDanmaku(object sender, BilibiliDM_PluginFramework.ReceivedDanmakuArgs e)
        {
            switch (e.Danmaku.MsgType)
            {
                case BilibiliDM_PluginFramework.MsgTypeEnum.GiftSend:
                    AddDM(e.Danmaku.GiftName, true);
                    bridge.ReadDanmaku(e.Danmaku);
                    break;
            }
        }
    }
}
