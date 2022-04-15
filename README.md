# Healther Locker

This tool is a try to generate a minimal executable in a dotnet environment and to provide a simple and unique functionality : URL test and return a usable code for a docker _healthcheck_ property

## Generation

The project target `net3.1`, `net5.0`, and `net6.0`.  
It will not generate files using the `self-contained` parameter as it currently aims to run on a dotnet docker image.

## TODO

* [ ] Check why the `self-contained` parameter generate a 70MB folder and not less :confused:
* [ ] Generate a version with `self-contained` parameter
* [ ] nuGetize all this
