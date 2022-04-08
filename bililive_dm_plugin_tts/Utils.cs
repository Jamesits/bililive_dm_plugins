using System.Text;

namespace bililive_dm_plugin_tts
{
    static class Utils
    {
        public static string GiftToString(BilibiliDM_PluginFramework.DanmakuModel d)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("感谢 {0} 投喂的 {1} 个 {2}", d.UserName, d.GiftCount, d.GiftName);
            return sb.ToString();
        }
    }
}
