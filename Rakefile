task :default do
  Dir.chdir("./src") do
    system "dotnet publish examples.sln -o bin"
    Dir["*.cs"].each do |script|
      name = File.basename script, '.cs'
      system "cd bin && dotnet ../../../neo/neo-compiler/neon/bin/neon.dll #{name}.dll"
      system "cp #{script} ../out"
      system "cp bin/#{name + '.avm'} ../out"
    end
  end
end

task :gen do
  name = ENV["NAME"] || 'NewContract'

  File.write "./src/#{name}.csproj", <<~EOF
    <Project Sdk="Microsoft.NET.Sdk">
      <PropertyGroup>
        <TargetFramework>netstandard1.6</TargetFramework>
        <EnableDefaultCompileItems>False</EnableDefaultCompileItems>
      </PropertyGroup>
      <ItemGroup>
        <Compile Include="#{name}.cs" />
        <PackageReference Include="Neo.SmartContract.Framework" Version="2.3.0" />
      </ItemGroup>
    </Project>
  EOF

  File.write "./src/#{name}.cs", <<~EOF
    using Neo.SmartContract.Framework.Services.Neo;

    namespace Neo.SmartContract
    {
      public class #{name} : Framework.SmartContract
      {
          public static void Main()
          {
          }
      }
    }
  EOF

  system "cd src && dotnet sln add #{name}.csproj"
end
