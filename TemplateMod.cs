using Terraria.ModLoader;

namespace TemplateTerrariaMod
{
    public class TemplateMod : Mod
    {
        public TemplateMod()
        {
            Properties = new ModProperties()
            {
                Autoload = true,
                AutoloadBackgrounds = true,
                AutoloadGores = true,
                AutoloadSounds = true
            };
        }
    }
}
