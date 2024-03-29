# pulse
[![Build Status](https://github.com/microsoft/pulse/actions/workflows/build.yml/badge.svg?branch=main)](https://github.com/microsoft/pulse/actions/workflows/build.yml)
[![codecov](https://codecov.io/gh/microsoft/pulse/branch/main/graph/badge.svg?token=BJH0u9ZUcC)](https://codecov.io/gh/microsoft/pulse)
[![Nuget](https://img.shields.io/nuget/v/pulse.svg)](https://www.nuget.org/packages/pulse/)
[![MIT License](https://img.shields.io/badge/license-MIT-green.svg)](https://github.com/microsoft/pulse/blob/main/LICENSE)

Pulse is a .NET library defining a common interface and metric configurations. Pulse's common interface allows you to develop metrics libraries that abstract an underlying monitoring system in a test-driven way.

Abstracted metrics libraries are helpful in the event the underlying monitoring system changes. Whether the underlying monitoring library experiences breaking changes or [you decide to do a complete swap of the underlying monitoring library](#switching-to-a-different-metrics-library), rest assured that you will only have to update the abstracted library and not your service code.

The library targets net5, net6, and net7.

## Download

[pulse](https://www.nuget.org/packages/pulse/) is distributed via the NuGet gallery.

## Projects Using pulse

* [pulse-prometheus](https://github.com/microsoft/pulse-prometheus)

## Switching to a Different Metrics Library?

* All [pulse-projects](#projects-using-pulse) implement the [pulse](#pulse) interface, meaning all [pulse-projects](#projects-using-pulse) are interchangable. 
* If you need to change monitoring systems in the future, you can do so without having to change your projects code!
* If a [pulse-project](#projects-using-pulse) does not exist for the metric monitoring system you need to use, you can easily create one by implementing the [pulse](#pulse) common interface.

## Contributing

See [CONTRIBUTING.md](CONTRIBUTING.md)

## Trademarks

This project may contain trademarks or logos for projects, products, or services. Authorized use of Microsoft 
trademarks or logos is subject to and must follow [Microsoft's Trademark & Brand Guidelines](https://www.microsoft.com/en-us/legal/intellectualproperty/trademarks/usage/general).

Use of Microsoft trademarks or logos in modified versions of this project must not cause confusion or imply Microsoft sponsorship.
Any use of third-party trademarks or logos are subject to those third-party's policies.
