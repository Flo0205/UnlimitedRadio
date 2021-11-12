using System.Linq;
using Synapse;
using Synapse.Api;
using Synapse.Api.Items;

namespace UnlimitedRadio
{
    public class EventHandlers
    {
        public EventHandlers()
        {
            Server.Get.Events.Server.UpdateEvent += OnUpdate;
        }

        private void OnUpdate()
        {
            foreach (Player p in SynapseController.Server.Players)
            {
                foreach (SynapseItem radio in p.Inventory.Items.Where(i => i.ItemCategory == ItemCategory.Radio))
                {
                    radio.Durabillity = 100;
                }
            }
        }
    }
}