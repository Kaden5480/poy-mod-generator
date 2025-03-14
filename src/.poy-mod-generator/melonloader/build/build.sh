#!/usr/bin/env bash

set -xe

cd ../

MOD_NAME="TemplateMod"
VERSION="$(git describe --abbrev=0 | tr -d  "v")"

ML_NAME="$MOD_NAME-$VERSION-MelonLoader"
ML_DIR="build/$ML_NAME"


dotnet build -c Release

mkdir -p "$ML_DIR"/Mods

# MelonLoader
cp bin/release/net472/"$MOD_NAME.dll" \
    "$ML_DIR/Mods/"
cp build/README.txt "$ML_DIR/README.txt"

# Zip everything
pushd "$ML_DIR"
zip -r ../"$ML_NAME.zip" .
popd

# Remove directories
rm -rf "$ML_DIR"
