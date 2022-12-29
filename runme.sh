#! /bin/bash

echo "Please enter your desired project name..."
read projectName

cd src
find . -depth -iname "*Placeholder*" -exec rename Placeholder $projectName '{}' \;
grep -rl Placeholder . | xargs sed -i "s/Placeholder/$projectName/g"

cd ../.github
find . -depth -iname "*Placeholder*" -exec rename Placeholder $projectName '{}' \;
grep -rl Placeholder . | xargs sed -i "s/Placeholder/$projectName/g"

rm ../runme.sh
