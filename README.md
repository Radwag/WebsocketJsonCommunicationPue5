# WebsocketJsonCommunicationPue5

[![Contributors][contributors-shield]][contributors-url]
[![Forks][forks-shield]][forks-url]
[![Stargazers][stars-shield]][stars-url]
[![Issues][issues-shield]][issues-url]

An example showing how to connect and communicate with a PUE 5 scale using WebSocket and Json.


# Technology
The repository contains two sample projects, "Sample WPF" and "Sample WinForms" and one liblary project "Services":
* Sample WPF was written in the Core .net5.0 framework and its and its presentation technology is WPF.
* Sample WinForms was written in Core .net5.0 framework and its presentation technology is WinForms.
* Services was written in Core .net5.0 framework.

# Working description
After connecting to the scale, you can read the current weight from the currently set platform,
You can also taring and zeroing the current platform. 
Additional controls located on the left side of the panel show the stability of the result and whether the scale is tared, zeroed.

The available options are in the app:
* Taring
* Zeroing
* Changing active platform
* Listing mass from active platform.

# WPF sample
![image](https://user-images.githubusercontent.com/46632727/162943984-f3311ca2-d434-4ce3-972e-48e909c80151.png)
# WinForms sample
![image](https://user-images.githubusercontent.com/46632727/162943885-9da5f310-8bf7-4e07-9063-073b62427784.png)

# Commands
* {'COMMAND': 'REGISTER_LISTENER', 'PARAM': 'MOD_INFO'} - this command registers the listener on the device which responds with the MOD_INFO command to the connected client automatically after each update of the device data, e.g. weight or time.
* {'COMMAND': 'EXECUTE_ACTION', 'PARAM': 'ActionChangePlatform'} - this command changes the platform.
* {'COMMAND': 'EXECUTE_ACTION', 'PARAM': 'ActionTarring'} - this command tarring the active platform.
* {'COMMAND': 'EXECUTE_ACTION', 'PARAM': 'ActionZeroing'} - this command zeroing the active platform.

# Structure of the MOD_INFO response
![image](https://user-images.githubusercontent.com/46632727/163121941-61360188-f4c5-4ad8-98c6-4c78a6076423.png)
![image](https://user-images.githubusercontent.com/46632727/163131056-cd2012e1-c402-4cee-a3a4-1b8f21563dab.png)

* Date(string) - current date and time from scale
* ActivePlatformIndex(intiger) - active platform index
* Mass(array) - array list of results
  * NetAct(array) - the current result
    * Value(double) - current value
    * Unit(string) - current unit
    * Precision(intiger) - current precision
  * NetCal(array) - the calibration result
    * Value(double) - calibration value
    * Unit(string) - calibration unit
    * Precision(intiger) - calibration precision
  
  * Tare(double) - tare value
  * Range(string) - range value
  * Max(double) - maximum calibration capacity
  * MaxAct(double) - maximum current capacity
  * IsStab(boolean) - if stable
  * IsTare(boolean) - if tared
  * IsZero(boolean) - if zeroed
  * HighlightedDigits(intiger) - the number of shaded digits
  * HiddenDigits(intiger) - the number of hidden digits
  * WeighingStatus(string) - weighing status
  * PlatformIndex(intiger) - index of platform
  * ErrorText(string) - the text of the error
  * BruttoInCal(double) - gross in adjustment weight

# Installation
1. Clone or download this repository.
2. Open project in Visual Studio.
3. Build and run.

[contributors-shield]: https://img.shields.io/github/contributors/Radwag/WebsocketJsonCommunicationPue5.svg?style=for-the-badge
[contributors-url]: https://github.com/Radwag/WebsocketJsonCommunicationPue5/contributors
[forks-shield]: https://img.shields.io/github/forks/Radwag/WebsocketJsonCommunicationPue5.svg?style=for-the-badge
[forks-url]: https://github.com/Radwag/WebsocketJsonCommunicationPue5/network/members
[stars-shield]: https://img.shields.io/github/stars/Radwag/WebsocketJsonCommunicationPue5.svg?style=for-the-badge
[stars-url]: https://github.com/Radwag/WebsocketJsonCommunicationPue5/stargazers
[issues-shield]: https://img.shields.io/github/issues/Radwag/WebsocketJsonCommunicationPue5.svg?style=for-the-badge
[issues-url]: https://github.com/Radwag/WebsocketJsonCommunicationPue5/issues
