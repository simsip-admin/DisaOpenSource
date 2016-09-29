using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using Disa.Framework.Bubbles;
using Refit;
using Models.Models.Types;
using System.Diagnostics;
using Models.Refit;
using Models.Services;

namespace Disa.Framework.Slack
{
    [ServiceInfo("SlackMessenger", true, false, false, false, false, typeof(SlackMessengerSettings), 
        ServiceInfo.ProcedureType.ConnectAuthenticate, typeof(TextBubble))]
    public class SlackMessenger : Service, IVisualBubbleServiceId
    {

        // Get a token for testing from your Slack dashboard
        // https://api.slack.com/docs/oauth-test-tokens
        public static string Token = "xoxp-14068036295-14068036311-14535092260-db883bb469";

        private IList<Channel> _slackChannels;

        private string _deviceId;
        private int _bubbleSendCount;


        public override bool Initialize(DisaSettings settings)
        {
            throw new NotImplementedException();
        }

        public override bool InitializeDefault()
        {
            _deviceId = Time.GetNowUnixTimestamp().ToString();
            return true;
        }

        public override bool Authenticate(WakeLock wakeLock)
        {
            return true;
        }

        public override void Deauthenticate()
        {
            // do nothing
        }

        public override async void Connect(WakeLock wakeLock)
        {
            var settings = new RefitSettings
            {
                UrlParameterFormatter = new CustomUrlParameterFormatter()
            };
            var api = RestService.For<IChannels>(("https://slack.com/api/"), settings);

            var channelsList = await api.ChannelsList();
            _slackChannels = channelsList.Channels;
        }

        public override void Disconnect()
        {
            // do nothing
        }

        public override string GetIcon(bool large)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<Bubble> ProcessBubbles()
        {
            throw new NotImplementedException();
        }

        private static string Reverse( string s )
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse( charArray );
            return new string( charArray );
        }

        public override void SendBubble(Bubble b)
        {
            var textBubble = b as TextBubble;
            if (textBubble != null)
            {
                Utils.Delay(2000).Wait();
                Platform.ScheduleAction(1, new WakeLockBalancer.ActionObject(() =>
                {
                    EventBubble(new TextBubble(Time.GetNowUnixTimestamp(), Bubble.BubbleDirection.Incoming,
                        textBubble.Address, null, false, this,  string.Format("Slack Channel [{0}]: {1}", _slackChannels[0].Name, textBubble.Message)));
                }, WakeLockBalancer.ActionObject.ExecuteType.TaskWithWakeLock));
            }
        }

        public override bool BubbleGroupComparer(string first, string second)
        {
            return first == second;
        }

        public override Task GetBubbleGroupLegibleId(BubbleGroup group, Action<string> result)
        {
            throw new NotImplementedException();
        }

        public override Task GetBubbleGroupName(BubbleGroup group, Action<string> result)
        {
            return Task.Factory.StartNew(() =>
            {
                result(group.Address);
            });
        }

        public override Task GetBubbleGroupPhoto(BubbleGroup group, Action<DisaThumbnail> result)
        {
            return Task.Factory.StartNew(() =>
            {
                result(null);
            });
        }

        public override Task GetBubbleGroupPartyParticipants(BubbleGroup group, Action<DisaParticipant[]> result)
        {
            throw new NotImplementedException();
        }

        public override Task GetBubbleGroupUnknownPartyParticipant(BubbleGroup group, string unknownPartyParticipant, Action<DisaParticipant> result)
        {
            throw new NotImplementedException();
        }

        public override Task GetBubbleGroupPartyParticipantPhoto(DisaParticipant participant, Action<DisaThumbnail> result)
        {
            throw new NotImplementedException();
        }

        public override Task GetBubbleGroupLastOnline(BubbleGroup group, Action<long> result)
        {
            throw new NotImplementedException();
        }

        public void AddVisualBubbleIdServices(VisualBubble bubble)
        {
            bubble.IdService = _deviceId + ++_bubbleSendCount;
        }

        public bool DisctinctIncomingVisualBubbleIdServices()
        {
            return true;
        }
    }

    public class SlackMessengerSettings : DisaSettings
    {
        // store settings in here:
        // e.g: public string Username { get; set; }
    }
}

