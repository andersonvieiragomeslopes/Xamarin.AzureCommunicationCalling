using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiACSTestSample
{
    public interface IConferenceManagerSpecificPlatform
    {
        Task<bool> Init(string token, string name);
        Task<ConferenceState> State();
        IReadOnlyCollection<ConferenceParticipant> Participants();
        void AddParticipants(string[] participantIds);
        Task AcceptAsync();
        Task RejectAsync();
        Task<string> GetServerCallId();
        Task InitializeConference(AzureSetupRoom azureSetupRoom);
        string CodeConference();
        void StartScreensharing();
        void SwitchCamera();
        void StartCamera();
        void RetrieveCameraPreview();
        void StopScreensharing();
        void StopCamera();
        void Hangup();
        void UnMuted();
        void Muted();
        Task<bool> InCall();
        DateTime? ConnectingStart { get; }
        DateTime? ConnectionStart { get; set; }
        Task<bool> MicrophoneMute();
        bool SpeakerOn { get; set; }
        bool Initialized { get; }
        Task<bool> MuteUnMuted();
        event EventHandler<View> LocalVideoAdded;
        event EventHandler<ParticipantVideoStatusChangedArgs> RemoteVideoRemoved;
        event EventHandler<ParticipantVideoStatusChangedArgs> RemoteVideoAdded;
        event EventHandler<ParticipantJoinArgs> ParticipantJoined;
        event EventHandler<ParticipantLeftArgs> ParticipantLeft;
        event EventHandler<ParticipantMicrophoneStatusChangedArgs> ParticipantMicrophoneStatusChanged;
        event EventHandler<ConferenceStateChangedEnventArgs> StateChanged;
        event EventHandler<ParticipantSpeakingStatusChangedArgs> SpeakingChanged;
    }
}
