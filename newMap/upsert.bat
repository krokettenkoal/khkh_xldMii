set ed=H:\Proj\kh2hlp\BAREd\bin\Debug\BAREd.exe
set to=H:\Proj\pcsx2\bin\inject.f266b00b\map\jp\eh18.map
pushd %~dp0
%ed% get sparse.map 04 04.bin
%ed% get sparse.map 05 05.bin
%ed% get sparse.map 06 06.bin
%ed% get sparse.map 07 07.bin
%ed% put "%to%" 04 04.bin MAP
%ed% put "%to%" 05 05.bin eh_1
%ed% put "%to%" 06 06.bin ID_e
%ed% put "%to%" 07 07.bin MAP
popd
