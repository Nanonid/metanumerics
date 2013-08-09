Portable Meta Numerics
======================

Copyright (c) 2009-2013 *ichbin*, portable adaptations (c) 2013 *Anders Gustafsson, Cureos AB*.<br/>The library is licensed under the [Microsoft Public License (Ms-PL)](http://opensource.org/licenses/MS-PL).

This is a manual fork of *ichbin's* [Meta Numerics](https://metanumerics.codeplex.com/) project, with adaptations necessary to build Meta Numerics as a portable class library.

The portable class library currently targets:

* Windows Store applications
* .NET Framework version 4 or higher
* Windows Phone version 7 and higher
* Silverlight version 4 or higher
* XBox 360

By manually re-targeting the PCL project, the library can also be built to target:

* Mono for Android
* Mono Touch

The solution contains one portable and one .NET only class library project. These two projects share the same code, except for binary serialization and ADO.NET support in a few classes that is only available in the .NET dedicated library.

*Portable Meta Numerics* aims to follow closely the updates of source code and binary releases made with *ichbin's* Meta Numerics. Currently, *Portable Meta Numerics* is related to *Meta Numerics* changeset [71976](https://metanumerics.codeplex.com/SourceControl/changeset/71976).