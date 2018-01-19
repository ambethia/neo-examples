class String
  def underscore
    self.gsub(/::/, '/').
    gsub(/([A-Z]+)([A-Z][a-z])/,'\1_\2').
    gsub(/([a-z])([A-Z])/,'\1_\2').
    gsub(/([a-z])([\d])/,'\1_\2').
    tr("-", "_").
    downcase
  end
end

desc 'Build changed contracts'
task :build do
  Dir.chdir("./src") do
    files = ENV['ALL'] ? Dir["*.cs"] : `git ls-files --exclude-standard -mo '*.cs'`.lines.map(&:chomp)
    files.each do |script|
      name = File.basename script, '.cs'
      system "dotnet publish #{name}.csproj -o bin"
      system "cd bin && dotnet ../../../neo/neo-compiler/neon/bin/neon.dll #{name}.dll"
      # system "cp #{script} ../out"
      system "cp -n #{script} ../../neo-ruby-sdk/test/fixtures/source/#{(name + '.rb').underscore}"
      # system "cp bin/#{name + '.avm'} ../out"
      system "cp bin/#{name + '.avm'} ../../neo-ruby-sdk/test/fixtures/binary/#{(name + '.avm').underscore}"
    end
  end
end

task default: :build

desc 'Modify build to compile all, not just changed'
task :all do
  ENV['ALL'] = '1'
end

desc "Generate a new contract from a template"
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
end
