Portable Meta Numerics
======================

This is a manual fork of ichbin's [Meta Numerics](https://metanumerics.codeplex.com/) project, with adaptations necessary to build Meta Numerics as a portable class library.

The portable class library currently targets:

* Windows Store applications
* .NET Framework version 4 or higher
* Windows Phone version 7 and higher
* Silverlight version 4 or higher
* XBox 360

The solution contains one portable and one .NET only class library project. These two projects share the same code, except for binary serialization and ADO.NET support in a few classes that is only available in the .NET dedicated library.