#!/bin/bash
echo Clearning Up Build Directory
rm -rf ../Build

echo Start building process
/home/summeryqc/Unity/Hub/Editor/2019.1.10f1/Editor/Unity \
	-quit \
	-batchmode \
	-ProjectPath .. \
	-executeMethod BuildScript.PerformBuild
echo End building process

