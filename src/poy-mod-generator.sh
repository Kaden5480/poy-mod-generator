#!/bin/sh

if [ $# -ne 4 ]; then
    printf "Usage: $(basename $0) <type> <repo-name> <assembly-name> <mod-name>\n"
    exit 1
fi

type="$1"
repo_name="$2"
repo_path="$repo_name"
assembly_name="$3"
mod_name="$4"

case "$type" in
    "combined" | "bepinex" | "melonloader")
    ;;
    *)
        printf "Unsupported type: $type\n"
        exit 1
    ;;
esac

# Do stuff
cp -r "$(dirname $0)/.poy-mod-generator/${type}" "$repo_path/"

if [ -f "$(dirname $0)/.poy-mod-generator/Config.props" ]; then
    cp "$(dirname $0)/.poy-mod-generator/Config.props" "$repo_path/"
fi

sed -i "s/TemplateMod/$assembly_name/g" "$repo_path/build/build.sh"

if [ "$type" = "combined" ]; then
    sed -i "s/Template Mod/$mod_name/g" "$repo_path/build/README-BepInEx.txt"
    sed -i "s/Template Mod/$mod_name/g" "$repo_path/build/README-MelonLoader.txt"
else
    sed -i "s/Template Mod/$mod_name/g" "$repo_path/build/README.txt"
fi

if [ "$type" = "melonloader" ]; then
    sed -i "s/TemplateMod/$assembly_name/g" "$repo_path/src/Mod.cs"
    sed -i "s/Template Mod/$mod_name/g" "$repo_path/src/Mod.cs"
    sed -i "s/poy-template-mod/$repo_name/g" "$repo_path/src/Mod.cs"
else
    sed -i "s/TemplateMod/$assembly_name/g" "$repo_path/src/Plugin.cs"
    sed -i "s/Template Mod/$mod_name/g" "$repo_path/src/Plugin.cs"
    sed -i "s/poy-template-mod/$repo_name/g" "$repo_path/src/Plugin.cs"
fi

sed -i "s/TemplateMod/$assembly_name/g" "$repo_path/README.md"
sed -i "s/Template Mod/$mod_name/g" "$repo_path/README.md"
sed -i "s/poy-template-mod/$repo_name/g" "$repo_path/README.md"

sed -i "s/TemplateMod/$assembly_name/g" "$repo_path/TemplateMod.csproj"
mv "$repo_path/TemplateMod.csproj" "$repo_path/$assembly_name.csproj"

