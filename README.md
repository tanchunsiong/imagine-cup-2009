# Imagine Cup 2009 - Sensor Monitoring System

Comprehensive sensor-based monitoring system with GPS tracking, motion detection, heat map visualization, and SMS alerts.

## Overview

Microsoft Imagine Cup 2009 competition entry. Multi-component system combining hardware sensors (GPS, compass, motion detection), data processing, web visualization, and alert mechanisms for environmental and security monitoring.

## Features

- GPS tracking with real-time location data
- Motion detection using DirectShow and VFW
- Heat map generation and visualization
- Badge sensor integration
- SMS alert system (ClickaTell)
- Web-based mapping interface (Virtual Earth)
- Sensor data processing and storage

## Components

### SensorController
Main application for sensor hardware integration and control.

### BadgeSensorWrapper
Library for badge sensor interfacing and data collection.

### motion_src
Motion detection library with DirectShow and VFW support.

### Imagine Cup 2009 Web Element
Web interface for data visualization using Virtual Earth/Bing Maps.

### heatmapgenerator
Heat map generation and survey validation tool.

### ClickaTellTester
SMS gateway testing and integration module.

## Technology Stack

**Languages:** C#, JavaScript  
**Framework:** .NET Framework, ASP.NET  
**Hardware:** GPS receivers, compass, motion sensors, badge sensors  
**Web:** Virtual Earth API, AJAX  
**Communication:** ClickaTell SMS API

## Architecture

```
Hardware Layer
├── GPS Module
├── Compass
├── Motion Sensors
└── Badge Sensors

Processing Layer
├── Sensor Controller
├── Motion Detection
└── Data Aggregation

Presentation Layer
├── Web Interface (Virtual Earth)
├── Heat Map Generation
└── SMS Alerts
```

## Installation

1. Clone repository
```bash
git clone https://github.com/tanchunsiong/imagine-cup-2009-sensors.git
```

2. Open individual component solutions in Visual Studio

3. Build each component

4. Configure hardware connections

5. Set up database and web server

6. Configure SMS gateway credentials

## Usage

1. Launch SensorController for hardware monitoring
2. Access web interface for visualization
3. Configure alert thresholds
4. Monitor heat maps and sensor data
5. Receive SMS alerts for events

## License

MIT License

## Links

- Blog post: [Imagine Cup 2009: Sensor-Based Conference Networking System](https://www.tanchunsiong.com/2009/07/imagine-cup-2009-sensor-based-conference-networking-system/)
- GitHub: [@tanchunsiong](https://github.com/tanchunsiong)
- LinkedIn: [tanchunsiong](https://www.linkedin.com/in/tanchunsiong)
- X/Twitter: [@tanchunsiong](https://x.com/tanchunsiong)

---

*Microsoft Imagine Cup 2009 Competition Entry*
