using ClassIsland.Shared.Abstraction.Models;
using CommunityToolkit.Mvvm.ComponentModel;

namespace ClassIsland.Models.NotificationProviderSettings;

public class
    AfterSchoolNotificationProviderSettings : ObservableRecipient, IAfterSchoolNotificationProviderSettingsBase
{
    private bool _isEnabled = true;
    private string _notificationMsg = "今天的课程已结束，请同学们有序离开。";
    private int _notificationMsgDuration = 30;

    public bool IsEnabled
    {
        get => _isEnabled;
        set
        {
            if (value == _isEnabled) return;
            _isEnabled = value;
            OnPropertyChanged();
        }
    }

    public string NotificationMsg
    {
        get => _notificationMsg;
        set
        {
            if (value == _notificationMsg) return;
            _notificationMsg = value;
            OnPropertyChanged();
        }
    }

    public int NotificationMsgDuration
    {
        get => _notificationMsgDuration;
        set
        {
            if (value == _notificationMsgDuration) return;
            _notificationMsgDuration = value;
            OnPropertyChanged();
        }
    }
}