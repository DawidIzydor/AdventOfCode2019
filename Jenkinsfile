node{
	stage 'checkout'{
		checkout scm
	}

	stage 'restore nuget{
		sh 'dotnet restore'
	}

	stage 'build'{
		sh 'dotnet build'
	}
}