//#if ANDROID
//using Android.Content;
//using Android.Media.Projection;
//using Com.Azure.Android.Communication.Calling;
//using Com.Azure.Android.Communication.Common;
//using Com.Laerdal.Azurecommunicationhelper;
//using MauiACSTestSample.Screensharing.Android;
//#elif WINDOWS
//using Azure.Communication.Calling;

//#else

//#endif
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace MauiACSTestSample
//{
//    public class ConferenceManagerSpecificPlatformService : IConferenceManagerSpecificPlatform
//    {
//#if ANDROID
//        private CallAgent _callAgent;
//        private CallClient _callClient;
//        private DeviceManager _deviceManager;
//        private LocalVideoStream _currentVideoStream = null;
//        private VideoStreamRenderer _previewRenderer;
//        VideoStreamRendererView _preview = null;

//        private VideoDeviceInfo _videoDeviceInfo = null;
//        IncomingCall _incomingCall;
//        private Call _call;

//#region Screensharing
//        public static MediaProjectionManager _mediaProjectionManager;
//        private MediaProjection _mediaProjection;
//        private OutgoingVideoStream outgoingVideoStream;
//        public static FrameGenerator frameGenerator;
//        public static OutgoingVideoStreamState outgoingVideoStreamState = OutgoingVideoStreamState.None;

//        private RawOutgoingVideoStreamOptions options;
//        private ScreenShareRawOutgoingVideoStream screenShareRawOutgoingVideoStream;
//        private OutgoingVideoStream videoOptions;
//#endregion
//        Context _appContext = Platform.AppContext;



//        private MainActivity MainActivity => (MainActivity)Platform.CurrentActivity;
//#endif
//#if WINDOWS
//        private CallAgent _callAgent;
//        private CallClient _callClient;
//        private DeviceManager _deviceManager;
//        private LocalVideoStream[] _localVideoStream;
//        private VideoDeviceInfo _videoDeviceInfo;
//        //private MediaElement mediaElement;
//        private Call _callWindows;
//#endif
//#if IOS
//#endif
//#if MACCATALYST
//#endif
//        public event EventHandler<View> LocalVideoAdded;
//        public event EventHandler<ParticipantVideoStatusChangedArgs> RemoteVideoAdded;
//        public event EventHandler<ParticipantVideoStatusChangedArgs> RemoteVideoRemoved;
//        public event EventHandler<ParticipantJoinArgs> ParticipantJoined;
//        public event EventHandler<ParticipantLeftArgs> ParticipantLeft;
//        public event EventHandler<ParticipantMicrophoneStatusChangedArgs> ParticipantMicrophoneStatusChanged;
//        public event EventHandler<ConferenceStateChangedEnventArgs> StateChanged;
//        public event EventHandler<ParticipantSpeakingStatusChangedArgs> SpeakingChanged = delegate { };

//        public DateTime? ConnectingStart => throw new NotImplementedException();

//        public DateTime? ConnectionStart { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

//        public bool Initialized { get; private set; } = false;

//        public bool SpeakerOn { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

//        public string DisplayName { get; set; }
//        public SelectedCamera CurrentCamera { get; set; } = SelectedCamera.Front;

//        public async Task<bool> MicrophoneMute()
//        {
//#if WINDOWS
//            return _callWindows.IsMuted;
//#elif ANDROID
//        return _call.IsMuted;

//#else
//return false;
//#endif

//        }
//        public async Task<ConferenceState> State()
//        {
//#if WINDOWS
//            return _callWindows != null && _callWindows.State == Azure.Communication.Calling.CallState.Connected ? ConferenceState.Connected : ConferenceState.Disconnected;
//#elif ANDROID
//       return _call != null && _call.State == CallState.Connected ? ConferenceState.Connected : ConferenceState.Disconnected;
//#else
//            return ConferenceState.Unset;
//#endif
//        }
//        public Task AcceptAsync()
//        {
//            throw new NotImplementedException();
//        }

//        public void AddParticipants(string[] participantIds)
//        {
//            throw new NotImplementedException();
//        }

//        public string CodeConference()
//        {
//            throw new NotImplementedException();
//        }

//        public Task<string> GetServerCallId()
//        {
//            throw new NotImplementedException();
//        }

//        public void Hangup()
//        {
//            throw new NotImplementedException();
//        }

//        public Task<bool> InCall()
//        {
//            throw new NotImplementedException();
//        }

//        public async Task<bool> Init(string token, string name)
//        {
//            try
//            {
//#if ANDROID
//                var credentials = new CommunicationTokenCredential(token);
//                var callOptions = new CallAgentOptions();
//                _callClient = new CallClient();
//                callOptions.SetDisplayName(DisplayName = name);
//                _callAgent = CallClientHelper.GetCallAgent(_callClient, _appContext, credentials, callOptions);
//                _deviceManager = CallClientHelper.GetDeviceManager(_callClient, _appContext);
//                return Initialized = true;
//#endif
//#if WINDOWS
//                global::Azure.WinRT.Communication.CommunicationTokenCredential token_credential = new global::Azure.WinRT.Communication.CommunicationTokenCredential(token);
//                CallClient callClient = new CallClient();
//                _deviceManager = await callClient.GetDeviceManager();
//                CallAgentOptions callAgentOptions = new CallAgentOptions()
//                {
//                    DisplayName = DisplayName = name
//                };
//                _callAgent = await callClient.CreateCallAgent(token_credential, callAgentOptions);

//                return Initialized = true;
//#endif
//#if IOS
//                return Initialized = true;

//#endif
//#if MACCATALYST
//                return Initialized = true;

//#endif
//            }
//            catch (System.Exception ex)
//            {
//                new ConferenceExceptions(ex);
//                return Initialized = false;
//            }
//        }

//        public Task InitializeConference(AzureSetupRoom azureSetupRoom)
//        {
//            throw new NotImplementedException();
//        }

//        public void Muted()
//        {
//            throw new NotImplementedException();
//        }

//        public Task<bool> MuteUnMuted()
//        {
//            throw new NotImplementedException();
//        }

//        public IReadOnlyCollection<ConferenceParticipant> Participants()
//        {
//            throw new NotImplementedException();
//        }

//        public Task RejectAsync()
//        {
//            throw new NotImplementedException();
//        }

//        public void RetrieveCameraPreview()
//        {
//            throw new NotImplementedException();
//        }

//        public void StartCamera()
//        {
//            throw new NotImplementedException();
//        }

//        public void StartScreensharing()
//        {
//            throw new NotImplementedException();
//        }

//        public void StopCamera()
//        {
//            throw new NotImplementedException();
//        }

//        public void StopScreensharing()
//        {
//            throw new NotImplementedException();
//        }

//        public void SwitchCamera()
//        {
//            throw new NotImplementedException();
//        }

//        public void UnMuted()
//        {
//            throw new NotImplementedException();
//        }
//    }
//}
