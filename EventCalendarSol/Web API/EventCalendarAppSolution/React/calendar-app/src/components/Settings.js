// SettingsPage.js

import React, { useState, useEffect } from 'react';

const SettingsPage = () => {
  const [userSettings, setUserSettings] = useState({
    notificationEnabled: true,
    theme: 'light',
    defaultView: 'month',
    defaultReminder: 15, // in minutes
    firstDayOfWeek: 'sunday',
  });

  useEffect(() => {
    fetchUserSettings();
  }, []);

  const fetchUserSettings = async () => {
    try {
      const response = await fetch('/api/settings');
      const data = await response.json();
      setUserSettings(data);
    } catch (error) {
      console.error('Error fetching user settings:', error);
    }
  };

  const updateSettings = async () => {
    try {
      const response = await fetch('/api/settings', {
        method: 'POST',
        headers: {
          'Content-Type': 'application/json',
        },
        body: JSON.stringify(userSettings),
      });

      if (response.ok) {
        console.log('Settings updated successfully!');
      } else {
        console.error('Failed to update settings');
      }
    } catch (error) {
      console.error('Error updating user settings:', error);
    }
  };

  return (
    <div>
      <h2>Settings</h2>
      <label>
        <input
          type="checkbox"
          checked={userSettings.notificationEnabled}
          onChange={() =>
            setUserSettings({
              ...userSettings,
              notificationEnabled: !userSettings.notificationEnabled,
            })
          }
        />
        Enable Notifications
      </label>

      <div>
        <label>
          Theme:
          <select
            value={userSettings.theme}
            onChange={(e) =>
              setUserSettings({ ...userSettings, theme: e.target.value })
            }
          >
            <option value="light">Light</option>
            <option value="dark">Dark</option>
          </select>
        </label>
      </div>

      <div>
        <label>
          Default View:
          <select
            value={userSettings.defaultView}
            onChange={(e) =>
              setUserSettings({ ...userSettings, defaultView: e.target.value })
            }
          >
            <option value="day">Day</option>
            <option value="week">Week</option>
            <option value="month">Month</option>
          </select>
        </label>
      </div>

      <div>
        <label>
          Default Reminder (minutes before event):
          <input
            type="number"
            value={userSettings.defaultReminder}
            onChange={(e) =>
              setUserSettings({
                ...userSettings,
                defaultReminder: parseInt(e.target.value, 10),
              })
            }
          />
        </label>
      </div>

      <div>
        <label>
          First Day of Week:
          <select
            value={userSettings.firstDayOfWeek}
            onChange={(e) =>
              setUserSettings({
                ...userSettings,
                firstDayOfWeek: e.target.value,
              })
            }
          >
            <option value="sunday">Sunday</option>
            <option value="monday">Monday</option>
            {/* Add more options for different cultures */}
          </select>
        </label>
      </div>

      <button onClick={updateSettings}>Save Settings</button>
    </div>
  );
};

export default SettingsPage;